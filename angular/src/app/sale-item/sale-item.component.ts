import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { SaleItemService, SaleItemDto, saleItemTypeOptions } from '@proxy/sale-items';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';


@Component({
  standalone: false,
  selector: 'app-sale-item',
  templateUrl: './sale-item.component.html',
  styleUrl: './sale-item.component.scss',
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class SaleItemComponent implements OnInit {
  saleItem = { items: [], totalCount: 0 } as PagedResultDto<SaleItemDto>;
  selectedItem = {} as SaleItemDto;
  form: FormGroup;
  saleItemTypes = saleItemTypeOptions;

  isModalOpen = false;

  constructor(
    public readonly list: ListService,
    private saleItemService: SaleItemService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) {}

  ngOnInit() {
    const saleItemStreamCreator = query => this.saleItemService.getList(query);

    this.list.hookToQuery(saleItemStreamCreator).subscribe(response => {
      this.saleItem = response;
    });
  }

  createSaleItem() {
    this.selectedItem = {} as SaleItemDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editSaleItem(id: string) {
    this.saleItemService.get(id).subscribe(saleItem => {
      this.selectedItem = saleItem;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  deleteSaleItem(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.saleItemService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedItem.name || '', Validators.required],
      type: [this.selectedItem.type || null, Validators.required],
      publishDate: [
        this.selectedItem.publishDate ? new Date(this.selectedItem.publishDate) : null,
        Validators.required,
      ],
      price: [this.selectedItem.price || null, Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedItem.id
      ? this.saleItemService.update(this.selectedItem.id, this.form.value)
      : this.saleItemService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}

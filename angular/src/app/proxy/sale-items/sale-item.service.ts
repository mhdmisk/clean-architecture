import type { CreateUpdateSaleItemDto, SaleItemDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SaleItemService {
  apiName = 'Default';
  

  create = (input: CreateUpdateSaleItemDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, SaleItemDto>({
      method: 'POST',
      url: '/api/app/sale-item',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/sale-item/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, SaleItemDto>({
      method: 'GET',
      url: `/api/app/sale-item/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<SaleItemDto>>({
      method: 'GET',
      url: '/api/app/sale-item',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateSaleItemDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, SaleItemDto>({
      method: 'PUT',
      url: `/api/app/sale-item/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}

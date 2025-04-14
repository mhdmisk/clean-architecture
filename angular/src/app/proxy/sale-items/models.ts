import type { SaleItemType } from './sale-item-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateSaleItemDto {
  name: string;
  type: SaleItemType;
  publishDate: string;
  price: number;
}

export interface SaleItemDto extends AuditedEntityDto<string> {
  name?: string;
  type?: SaleItemType;
  publishDate?: string;
  price: number;
}

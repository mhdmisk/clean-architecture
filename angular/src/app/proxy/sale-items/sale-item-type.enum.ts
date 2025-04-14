import { mapEnumToOptions } from '@abp/ng.core';

export enum SaleItemType {
  New = 0,
  Used = 1,
}

export const saleItemTypeOptions = mapEnumToOptions(SaleItemType);

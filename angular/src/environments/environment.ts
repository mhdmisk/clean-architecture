 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44354/',
  redirectUri: baseUrl,
  clientId: 'Bookstore_App',
  responseType: 'code',
  scope: 'offline_access Bookstore',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Bookstore',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44354',
      rootNamespace: 'AbpSolution.Bookstore',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;

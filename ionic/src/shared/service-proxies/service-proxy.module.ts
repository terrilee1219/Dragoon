import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AbpHttpInterceptor, AbpHttpConfiguration } from '@abp/abpHttpInterceptor';
import * as ApiServiceProxies from './service-proxies';
import { MessageService } from 'abp-ng2-module/dist/src/message/message.service';
import { LogService } from 'abp-ng2-module/dist/src/log/log.service';

@NgModule({
    providers: [
        ApiServiceProxies.RoleServiceProxy,
        ApiServiceProxies.SessionServiceProxy,
        ApiServiceProxies.TenantServiceProxy,
        ApiServiceProxies.UserServiceProxy,
        ApiServiceProxies.TokenAuthServiceProxy,
        ApiServiceProxies.AccountServiceProxy,
        ApiServiceProxies.ConfigurationServiceProxy,
        AbpHttpConfiguration,
        MessageService,
        LogService,
        { provide: HTTP_INTERCEPTORS, useClass: AbpHttpInterceptor, multi: true }
    ]
})
export class ServiceProxyModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AppComponent } from './app.component';
import { RootComponent } from './root.component';
import { AppRoutingModule } from './app-routing.module';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapModule, WebMapService, WEBMAP_CONFIG, WebMapServiceConfig } from '@mobilize/angularclient';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { HttpClientXsrfModule } from '@angular/common/http';
import { PbjWebmapdemoModule } from './pbj_webmapdemo.module';
import { FeaturesModule } from './features.module';
import { MulticontroldemoModule } from './multicontroldemo.module';
import { BasecomponentsModule } from './basecomponents.module';
import { ModelsModule } from './models.module';
import { MedicationcenterModule } from './medicationcenter.module';
import { ReportsModule } from './reports.module';
import { NotifycurrentcontrolModule } from './notifycurrentcontrol.module';
const config: WebMapServiceConfig = {
  useDynamicServerEvents: true,
  webMapVersion: 'v5',
  usePercentage: false,
  useBundleEvent: true,
  showBrowserContextMenu: true,
  baseHref: '',
  dataManagerBusyLoaderTime: 0,
  wmSourceVersion: 'PB',
  styleProperties:[],
};

@NgModule({
declarations: [
AppComponent,
RootComponent
],
imports: [
	HttpClientXsrfModule.withOptions({
		cookieName: "pbj_webmapdemo-Xsrf-Cookie",
		headerName: "pbj_webmapdemo-Xsrf-Header",
	}),
BrowserModule,
WebMapModule,
AppRoutingModule,
BaseComponentsModule,
PowerComponentsModule,
PbjWebmapdemoModule,
FeaturesModule,
MulticontroldemoModule,
BasecomponentsModule,
ModelsModule,
MedicationcenterModule,
ReportsModule,
NotifycurrentcontrolModule,
],
providers: [WebMapService, { provide: WEBMAP_CONFIG, useValue: config }
],
bootstrap: [AppComponent],
schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }


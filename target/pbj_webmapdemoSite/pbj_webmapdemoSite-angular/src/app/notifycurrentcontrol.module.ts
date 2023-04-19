
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Notifycurrentcontrol from './components/notifycurrentcontrol';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Notifycurrentcontrol.DCurrentControlChangeComponent,
  Notifycurrentcontrol.DDdddwComponent,
  Notifycurrentcontrol.DExpressionsComponent,
  Notifycurrentcontrol.DStreetComponent,
  Notifycurrentcontrol.DUsersComponent,
  Notifycurrentcontrol.WDropdownComponent,
  Notifycurrentcontrol.WExpressionsComponent,
  Notifycurrentcontrol.WShareddatawindowComponent,
  Notifycurrentcontrol.WWindowComponent,
    ],
  declarations: [
  Notifycurrentcontrol.DCurrentControlChangeComponent,
  Notifycurrentcontrol.DDdddwComponent,
  Notifycurrentcontrol.DExpressionsComponent,
  Notifycurrentcontrol.DStreetComponent,
  Notifycurrentcontrol.DUsersComponent,
  Notifycurrentcontrol.WDropdownComponent,
  Notifycurrentcontrol.WExpressionsComponent,
  Notifycurrentcontrol.WShareddatawindowComponent,
  Notifycurrentcontrol.WWindowComponent,
    ],
  bootstrap: [
  Notifycurrentcontrol.DCurrentControlChangeComponent,
  Notifycurrentcontrol.DDdddwComponent,
  Notifycurrentcontrol.DExpressionsComponent,
  Notifycurrentcontrol.DStreetComponent,
  Notifycurrentcontrol.DUsersComponent,
  Notifycurrentcontrol.WDropdownComponent,
  Notifycurrentcontrol.WExpressionsComponent,
  Notifycurrentcontrol.WShareddatawindowComponent,
  Notifycurrentcontrol.WWindowComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class NotifycurrentcontrolModule { }


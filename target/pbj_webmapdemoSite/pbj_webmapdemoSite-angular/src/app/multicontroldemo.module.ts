
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Multicontroldemo from './components/multicontroldemo';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Multicontroldemo.DwAllcontrolsOneComponent,
  Multicontroldemo.DwAllcontrolsTwoComponent,
  Multicontroldemo.DwDddwsourceComponent,
  Multicontroldemo.DDwControlSamplerComponent,
  Multicontroldemo.DEmployeeDeptInfoUpdateDddwComponent,
  Multicontroldemo.DEmployeeInfoUpdateComponent,
  Multicontroldemo.DEmployeeInfoUpdateGridComponent,
  Multicontroldemo.DNoDataComponent,
  Multicontroldemo.DWithDataComponent,
  Multicontroldemo.WAllinformationComponent,
  Multicontroldemo.WDatawindowStatesComponent,
  Multicontroldemo.WDwControlSamplerEventsComponent,
  Multicontroldemo.WEmployeeMaintUpdatesComponent,
    ],
  declarations: [
  Multicontroldemo.DwAllcontrolsOneComponent,
  Multicontroldemo.DwAllcontrolsTwoComponent,
  Multicontroldemo.DwDddwsourceComponent,
  Multicontroldemo.DDwControlSamplerComponent,
  Multicontroldemo.DEmployeeDeptInfoUpdateDddwComponent,
  Multicontroldemo.DEmployeeInfoUpdateComponent,
  Multicontroldemo.DEmployeeInfoUpdateGridComponent,
  Multicontroldemo.DNoDataComponent,
  Multicontroldemo.DWithDataComponent,
  Multicontroldemo.WAllinformationComponent,
  Multicontroldemo.WDatawindowStatesComponent,
  Multicontroldemo.WDwControlSamplerEventsComponent,
  Multicontroldemo.WEmployeeMaintUpdatesComponent,
    ],
  bootstrap: [
  Multicontroldemo.DwAllcontrolsOneComponent,
  Multicontroldemo.DwAllcontrolsTwoComponent,
  Multicontroldemo.DwDddwsourceComponent,
  Multicontroldemo.DDwControlSamplerComponent,
  Multicontroldemo.DEmployeeDeptInfoUpdateDddwComponent,
  Multicontroldemo.DEmployeeInfoUpdateComponent,
  Multicontroldemo.DEmployeeInfoUpdateGridComponent,
  Multicontroldemo.DNoDataComponent,
  Multicontroldemo.DWithDataComponent,
  Multicontroldemo.WAllinformationComponent,
  Multicontroldemo.WDatawindowStatesComponent,
  Multicontroldemo.WDwControlSamplerEventsComponent,
  Multicontroldemo.WEmployeeMaintUpdatesComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class MulticontroldemoModule { }


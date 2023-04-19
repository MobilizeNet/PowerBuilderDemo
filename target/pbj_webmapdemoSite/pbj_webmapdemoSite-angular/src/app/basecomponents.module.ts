
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Basecomponents from './components/basecomponents';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Basecomponents.WBasewindowComponent,
    ],
  declarations: [
  Basecomponents.WBasewindowComponent,
    ],
  bootstrap: [
  Basecomponents.WBasewindowComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class BasecomponentsModule { }


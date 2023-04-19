
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Models from './components/models';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Models.WDummyComponent,
    ],
  declarations: [
  Models.WDummyComponent,
    ],
  bootstrap: [
  Models.WDummyComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class ModelsModule { }


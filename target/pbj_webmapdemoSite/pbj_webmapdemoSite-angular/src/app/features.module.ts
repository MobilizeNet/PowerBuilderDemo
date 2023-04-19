
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Features from './components/features';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Features.WDummyfeaturesComponent,
    ],
  declarations: [
  Features.WDummyfeaturesComponent,
    ],
  bootstrap: [
  Features.WDummyfeaturesComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class FeaturesModule { }


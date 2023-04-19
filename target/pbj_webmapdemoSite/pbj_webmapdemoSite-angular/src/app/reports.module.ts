
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Reports from './components/reports';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Reports.DwBirthdayComponent,
  Reports.DwPersonlistComponent,
  Reports.DwProductComponent,
  Reports.WMainReportComponent,
    ],
  declarations: [
  Reports.DwBirthdayComponent,
  Reports.DwPersonlistComponent,
  Reports.DwProductComponent,
  Reports.WMainReportComponent,
    ],
  bootstrap: [
  Reports.DwBirthdayComponent,
  Reports.DwPersonlistComponent,
  Reports.DwProductComponent,
  Reports.WMainReportComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class ReportsModule { }


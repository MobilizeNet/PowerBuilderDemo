
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as Medicationcenter from './components/medicationcenter';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  Medicationcenter.DAddprescriptionComponent,
  Medicationcenter.DDddwprescriptionComponent,
  Medicationcenter.DRemoveprescriptionComponent,
  Medicationcenter.DSearchprescriptionComponent,
  Medicationcenter.DShowallprescrpitionComponent,
  Medicationcenter.OuShowallprescriptionsComponent,
  Medicationcenter.TbTabbaseComponent,
  Medicationcenter.UoOkcancelretryComponent,
  Medicationcenter.WBasemdiComponent,
  Medicationcenter.WLoginComponent,
  Medicationcenter.WLoginbaseComponent,
  Medicationcenter.WMdiComponent,
  Medicationcenter.WPrescriptionmantComponent,
  Medicationcenter.WTabbaseComponent,
    ],
  declarations: [
  Medicationcenter.DAddprescriptionComponent,
  Medicationcenter.DDddwprescriptionComponent,
  Medicationcenter.DRemoveprescriptionComponent,
  Medicationcenter.DSearchprescriptionComponent,
  Medicationcenter.DShowallprescrpitionComponent,
  Medicationcenter.OuShowallprescriptionsComponent,
  Medicationcenter.TbTabbaseComponent,
  Medicationcenter.UoOkcancelretryComponent,
  Medicationcenter.WBasemdiComponent,
  Medicationcenter.WLoginComponent,
  Medicationcenter.WLoginbaseComponent,
  Medicationcenter.WMdiComponent,
  Medicationcenter.WPrescriptionmantComponent,
  Medicationcenter.WTabbaseComponent,
    ],
  bootstrap: [
  Medicationcenter.DAddprescriptionComponent,
  Medicationcenter.DDddwprescriptionComponent,
  Medicationcenter.DRemoveprescriptionComponent,
  Medicationcenter.DSearchprescriptionComponent,
  Medicationcenter.DShowallprescrpitionComponent,
  Medicationcenter.OuShowallprescriptionsComponent,
  Medicationcenter.TbTabbaseComponent,
  Medicationcenter.UoOkcancelretryComponent,
  Medicationcenter.WBasemdiComponent,
  Medicationcenter.WLoginComponent,
  Medicationcenter.WLoginbaseComponent,
  Medicationcenter.WMdiComponent,
  Medicationcenter.WPrescriptionmantComponent,
  Medicationcenter.WTabbaseComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class MedicationcenterModule { }


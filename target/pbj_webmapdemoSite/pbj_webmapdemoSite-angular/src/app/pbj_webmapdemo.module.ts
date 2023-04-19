
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { PowerComponentsModule } from '@mobilize/powercomponents';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as PbjWebmapdemo from './components/pbj_webmapdemo';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    PowerComponentsModule,
    WebMapModule,
  ],
  exports: [
  PbjWebmapdemo.DwBrandsComponent,
  PbjWebmapdemo.DwCategoriesComponent,
  PbjWebmapdemo.DwCategoriesFreeformComponent,
  PbjWebmapdemo.DwProductsbrandComponent,
  PbjWebmapdemo.WCheckBoxComponent,
  PbjWebmapdemo.WCommandButtonComponent,
  PbjWebmapdemo.WDropdownListboxComponent,
  PbjWebmapdemo.WDwDropdowndatawindowComponent,
  PbjWebmapdemo.WDwFeaturesComponent,
  PbjWebmapdemo.WEditMaskComponent,
  PbjWebmapdemo.WMutiLineEditComponent,
  PbjWebmapdemo.WPbjMainComponent,
  PbjWebmapdemo.WPictureComponent,
  PbjWebmapdemo.WPictureButtonComponent,
  PbjWebmapdemo.WRadioButtonComponent,
  PbjWebmapdemo.WSingleLineEditComponent,
  PbjWebmapdemo.WStaticTextComponent,
    ],
  declarations: [
  PbjWebmapdemo.DwBrandsComponent,
  PbjWebmapdemo.DwCategoriesComponent,
  PbjWebmapdemo.DwCategoriesFreeformComponent,
  PbjWebmapdemo.DwProductsbrandComponent,
  PbjWebmapdemo.WCheckBoxComponent,
  PbjWebmapdemo.WCommandButtonComponent,
  PbjWebmapdemo.WDropdownListboxComponent,
  PbjWebmapdemo.WDwDropdowndatawindowComponent,
  PbjWebmapdemo.WDwFeaturesComponent,
  PbjWebmapdemo.WEditMaskComponent,
  PbjWebmapdemo.WMutiLineEditComponent,
  PbjWebmapdemo.WPbjMainComponent,
  PbjWebmapdemo.WPictureComponent,
  PbjWebmapdemo.WPictureButtonComponent,
  PbjWebmapdemo.WRadioButtonComponent,
  PbjWebmapdemo.WSingleLineEditComponent,
  PbjWebmapdemo.WStaticTextComponent,
    ],
  bootstrap: [
  PbjWebmapdemo.DwBrandsComponent,
  PbjWebmapdemo.DwCategoriesComponent,
  PbjWebmapdemo.DwCategoriesFreeformComponent,
  PbjWebmapdemo.DwProductsbrandComponent,
  PbjWebmapdemo.WCheckBoxComponent,
  PbjWebmapdemo.WCommandButtonComponent,
  PbjWebmapdemo.WDropdownListboxComponent,
  PbjWebmapdemo.WDwDropdowndatawindowComponent,
  PbjWebmapdemo.WDwFeaturesComponent,
  PbjWebmapdemo.WEditMaskComponent,
  PbjWebmapdemo.WMutiLineEditComponent,
  PbjWebmapdemo.WPbjMainComponent,
  PbjWebmapdemo.WPictureComponent,
  PbjWebmapdemo.WPictureButtonComponent,
  PbjWebmapdemo.WRadioButtonComponent,
  PbjWebmapdemo.WSingleLineEditComponent,
  PbjWebmapdemo.WStaticTextComponent,
    ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class PbjWebmapdemoModule { }


import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-dw_categories",
   templateUrl : "dw_categories.component.html",
   styleUrls : ["dw_categories.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["pbj_webmapdemodw_categories"])
export class DwCategoriesComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      id : 0,
      name : 1
   };
   headerTemplates = {
      id_t : 0,
      name_t : 1
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-dw_categories_freeform",
   templateUrl : "dw_categories_freeform.component.html",
   styleUrls : ["dw_categories_freeform.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["pbj_webmapdemodw_categories_freeform"])
export class DwCategoriesFreeformComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
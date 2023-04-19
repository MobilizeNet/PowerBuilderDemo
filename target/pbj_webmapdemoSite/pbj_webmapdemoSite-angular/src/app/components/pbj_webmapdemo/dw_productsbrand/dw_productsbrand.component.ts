import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-dw_productsbrand",
   templateUrl : "dw_productsbrand.component.html",
   styleUrls : ["dw_productsbrand.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["pbj_webmapdemodw_productsbrand"])
export class DwProductsbrandComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      id : 0,
      name : 1,
      brandid : 2
   };
   headerTemplates = {
      id_t : 0,
      name_t : 1,
      brandid_t : 2
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
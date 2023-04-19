import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-dw_allcontrols_two",
   templateUrl : "dw_allcontrols_two.component.html",
   styleUrls : ["dw_allcontrols_two.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemodw_allcontrols_two"])
export class DwAllcontrolsTwoComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
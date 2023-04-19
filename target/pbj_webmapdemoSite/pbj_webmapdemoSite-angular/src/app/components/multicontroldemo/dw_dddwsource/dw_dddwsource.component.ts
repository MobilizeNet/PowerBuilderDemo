import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-dw_dddwsource",
   templateUrl : "dw_dddwsource.component.html",
   styleUrls : ["dw_dddwsource.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemodw_dddwsource"])
export class DwDddwsourceComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      type_name : 0,
      type_desc : 1,
      type_value : 2
   };
   headerTemplates = {
      type_value_t : 0
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
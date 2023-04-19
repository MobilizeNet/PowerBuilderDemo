import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_expressions",
   templateUrl : "d_expressions.component.html",
   styleUrls : ["d_expressions.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["notifycurrentcontrold_expressions"])
export class DExpressionsComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      id : 0,
      street : 1,
      compute_1 : 2,
      compute_2 : 3
   };
   headerTemplates = {
      id_t : 0,
      street_t : 1,
      t_1 : 2,
      t_2 : 3
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
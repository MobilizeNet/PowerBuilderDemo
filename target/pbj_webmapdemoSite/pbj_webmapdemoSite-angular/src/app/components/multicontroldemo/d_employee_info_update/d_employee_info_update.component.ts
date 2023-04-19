import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_employee_info_update",
   templateUrl : "d_employee_info_update.component.html",
   styleUrls : ["d_employee_info_update.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemod_employee_info_update"])
export class DEmployeeInfoUpdateComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
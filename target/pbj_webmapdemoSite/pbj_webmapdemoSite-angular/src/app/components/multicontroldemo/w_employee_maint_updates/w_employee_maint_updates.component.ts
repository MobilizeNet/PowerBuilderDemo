import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-employee-maint-updates",
   templateUrl : "w_employee_maint_updates.component.html",
   styleUrls : ["w_employee_maint_updates.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemow_employee_maint_updates"])
export class WEmployeeMaintUpdatesComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
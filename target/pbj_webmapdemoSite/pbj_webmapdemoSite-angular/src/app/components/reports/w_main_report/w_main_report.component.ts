import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-main-report",
   templateUrl : "w_main_report.component.html",
   styleUrls : ["w_main_report.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["reportsw_main_report"])
export class WMainReportComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
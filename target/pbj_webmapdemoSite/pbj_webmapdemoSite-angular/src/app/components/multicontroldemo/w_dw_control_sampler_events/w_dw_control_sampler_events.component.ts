import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-dw-control-sampler-events",
   templateUrl : "w_dw_control_sampler_events.component.html",
   styleUrls : ["w_dw_control_sampler_events.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemow_dw_control_sampler_events"])
export class WDwControlSamplerEventsComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
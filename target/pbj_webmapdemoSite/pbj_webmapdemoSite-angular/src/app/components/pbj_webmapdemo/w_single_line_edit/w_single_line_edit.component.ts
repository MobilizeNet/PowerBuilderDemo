import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-w-single-line-edit",
   templateUrl : "w_single_line_edit.component.html",
   styleUrls : ["w_single_line_edit.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["pbj_webmapdemow_single_line_edit"])
export class WSingleLineEditComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
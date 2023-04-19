import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { BaseControlComponent, LengthConverter} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-tb-tabbase",
   templateUrl : "tb_tabbase.component.html",
   styleUrls : ["tb_tabbase.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["medicationcentertb_tabbase"])
export class TbTabbaseComponent extends BaseControlComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter) {
      super(changeDetector,render2,elem,lengthConverter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
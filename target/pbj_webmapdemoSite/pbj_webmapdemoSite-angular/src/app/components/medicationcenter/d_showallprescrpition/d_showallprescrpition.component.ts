import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_showallprescrpition",
   templateUrl : "d_showallprescrpition.component.html",
   styleUrls : ["d_showallprescrpition.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["medicationcenterd_showallprescrpition"])
export class DShowallprescrpitionComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      iid : 0,
      medicine : 1,
      patient : 2,
      dose : 3,
      socialsecurity : 4
   };
   headerTemplates = {
      id_t : 0,
      medicine_t : 1,
      patient_t : 2,
      dose_t : 3,
      socialsecurity_t : 4
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
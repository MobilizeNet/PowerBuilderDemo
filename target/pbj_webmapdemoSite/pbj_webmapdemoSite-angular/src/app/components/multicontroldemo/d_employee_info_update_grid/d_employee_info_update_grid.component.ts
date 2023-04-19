import { Component, OnInit, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation, Optional} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { BaseControlComponent, DataManagerEventService, LengthConverter} from "@mobilize/powercomponents";
@Component({
   selector : "app-d_employee_info_update_grid",
   templateUrl : "d_employee_info_update_grid.component.html",
   styleUrls : ["d_employee_info_update_grid.component.css"],
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["multicontroldemod_employee_info_update_grid"])
export class DEmployeeInfoUpdateGridComponent extends BaseControlComponent implements OnInit {
   columnTemplates = {
      level : 0,
      tregistered : 1,
      tname : 2,
      tage : 3,
      tdescription : 4,
      tdepartment : 5,
      tsalary : 6,
      tcategory : 7,
      thiredate : 8,
      tlastlogin : 9
   };
   headerTemplates = {
      level_t : 0,
      tregistered_t : 1,
      tname_t : 2,
      tage_t : 3,
      tdescription_t : 4,
      tdepartment_t : 5,
      tsalary_t : 6,
      tcategory_t : 7,
      thiredate_t : 8,
      tlastlogin_t : 9
   };
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private emmiter : DataManagerEventService = null) {
      super(changeDetector,render2,elem,lengthConverter,emmiter);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
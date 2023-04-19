import { Component, OnInit, Optional, ChangeDetectorRef, Renderer2, ElementRef, ViewEncapsulation} from "@angular/core";
import { UserObjectComponent, UserObjectEventService, MainTabOrderService, LengthConverter, ContainerControlTabOrderService, DataManagerEventService} from "@mobilize/powercomponents";
import { dataTransfer} from "@mobilize/base-components";
@Component({
   selector : "app-uo-okcancelretry",
   templateUrl : "uo_okcancelretry.component.html",
   styleUrls : ["uo_okcancelretry.component.css"],
   encapsulation : ViewEncapsulation.None,
   providers : [ContainerControlTabOrderService]
})
@dataTransfer(["medicationcenteruo_okcancelretry"])
export class UoOkcancelretryComponent extends UserObjectComponent implements OnInit {
   constructor (changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef,lengthConverter : LengthConverter,private mtOService : MainTabOrderService,@Optional() private uOEventService : UserObjectEventService,@Optional() private eventEmitterService : DataManagerEventService,@Optional() private tabContService : ContainerControlTabOrderService) {
      super(changeDetector,render2,elem,lengthConverter,mtOService,uOEventService,eventEmitterService,tabContService);
   }
   ngOnInit () {
      super.ngOnInit();
   }
}
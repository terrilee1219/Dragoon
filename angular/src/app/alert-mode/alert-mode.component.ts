import { Component, OnInit, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'app-alert-mode',
  templateUrl: './alert-mode.component.html',
  styleUrls: ['./alert-mode.component.css'],
  animations: [appModuleAnimation()]
})
export class AlertModeComponent extends AppComponentBase {

  constructor(
    injector: Injector
    ) {
    super(injector);
    }

  ngOnInit() {
  }

}

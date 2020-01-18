import { Component } from '@angular/core';
import {
UserServiceProxy, UserDto, UserDtoPagedResultDto
} from '../../shared/service-proxies/service-proxies';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

  constructor(private _userService: UserServiceProxy,) {

    /* console.log("calling user service");
    _userService.getAll("",true,0, 10).subscribe((result: UserDtoPagedResultDto) => {
      console.log(result);
    }); */

  }

  

}

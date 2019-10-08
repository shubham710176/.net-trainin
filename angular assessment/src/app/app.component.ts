import { Component } from '@angular/core';
import { EmpreadComponent } from './empread/empread.component';
import {EmployeeService} from './employee.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  title = 'crud-demo';
  
  
  constructor(private emp:EmployeeService){

  
  }
 onDelete(value){
   this.emp.removeemployee(value)

 }

}

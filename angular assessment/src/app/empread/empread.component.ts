import { Component,OnInit} from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Employee } from '../empolyee';


@Component({
  selector: 'app-empread',
  templateUrl: './empread.component.html',
  styleUrls: ['./empread.component.css']
})
export class EmpreadComponent implements OnInit  {
  emplist:Employee[];

  constructor(public emp:EmployeeService ){}
    
  ngOnInit(){
    this.emplist = this.emp.emplist;
    
  }
  
  onDelete(data){
    this.emp.removeemployee(data);
    console.log(data)
   }
   edit(editdata){
      this.emp.editemployee(editdata);    
   }
}



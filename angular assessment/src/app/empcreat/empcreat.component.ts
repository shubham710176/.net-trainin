import { Component, OnInit } from '@angular/core';

import {EmployeeService} from '../employee.service';

import {Employee} from '../empolyee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-empcreat',
  templateUrl: './empcreat.component.html',
  styleUrls: ['./empcreat.component.css']
})
export class EmpcreatComponent implements OnInit {

  emp = new Employee();
 constructor(private es:EmployeeService,private router:Router){


 }
 
  ngOnInit() {
    
  }
  saveemployee():void{
    this.es.showemployees(this.emp)
    this.router.navigate(['/READ']);
    // this.id=this.es.emplist.length;
    // this.em=new Employee(this.id,this.name,this.gender,this.dateofbirth,this.salary);
   
    // this.es.emplist.push(this.em);
    // console.log(this.es.emplist);
    // this.em=new Employee();

  }

}

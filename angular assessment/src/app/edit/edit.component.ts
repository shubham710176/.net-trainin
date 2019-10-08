import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {EmployeeService} from '../employee.service';
import {Employee} from '../empolyee';
@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  editemp;

  // name:string="";
  // id:number=0;
  // gender:string="";
  // dob:string="";
  // salary:string="";
  // index:number=0;
  constructor(private emp:EmployeeService,private router:Router) { }

  ngOnInit() {
  //  this.index=parseInt(this.route.snapshot.paramMap.get('id'));
   this.editemp=this.emp.editdata;
   console.log(this.editemp);
  }

  update()
  {
    this.emp.removeemployee(this.editemp);
    this.emp.showemployees(this.editemp);
    this.router.navigate(['/READ']);
    // this.emp.emplist[this.index]=new Employee(this.index,this.name,this.gender,this.dob,this.salary);
    // console.log(this.emp.emplist);
    
  }

}

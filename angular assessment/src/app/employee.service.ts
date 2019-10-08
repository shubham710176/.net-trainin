import { Injectable } from '@angular/core';
import { Employee} from './empolyee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  editdata=Employee;

  constructor() { }
  emplist:Employee[]=[
    {department_id:1, de_name:'Engineering', groupname:'Research and development',modified_date:new Date('2002-06-1')},
    {department_id:2, de_name:'Tools design', groupname:'Research and development',modified_date:new Date('2002-06-1')}
  ];
  showemployees(employee){
    this.emplist.push(employee)
    // console.log(this.emplist)
    // return this.emplist;
  }

  removeemployee(data){

    for(let i=0;i<this.emplist.length;i++){

    if(data == this.emplist[i]){
     this.emplist.splice(i,1);

              }
                                          }
                       }
   editemployee(emp){
      this.editdata=emp;
    }

}


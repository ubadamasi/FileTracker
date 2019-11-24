import { Component, OnInit } from "@angular/core";
import { DepartmentService } from "../../services/department.service";
import { AlertifyService } from "../../services/alertify.service";
import { Department } from "../../models/department";
import { NgForm } from "@angular/forms";

@Component({
  selector: "app-department-form",
  templateUrl: "./department-form.component.html",
  styleUrls: ["./department-form.component.css"]
})
export class DepartmentFormComponent implements OnInit {
  // model: any = {};
  department: Department;

  constructor(
    private departmentService: DepartmentService,
    private alertify: AlertifyService
  ) {}

  ngOnInit() {}

  onSubmit() {
    // this.departmentService.postDepartment(this.model).subscribe(
    //   next => {
    //     this.departmentService.postDepartment(this.model);
    //     console.log(this.model);
    //     this.resetForm();
    //     this.alertify.success("Added Successfully");
    //   },
    //   error => {
    //     this.alertify.error(error);
    //   }
    // );
    console.log(this.department);
    this.resetForm();
    this.alertify.success("i de work");
  }

  resetForm(departmentForm?: NgForm) {
    if (departmentForm != null) departmentForm.resetForm;

    this.department = {
      name: "",
      id: null
    };
  }
}

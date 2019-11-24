import { Component, OnInit } from "@angular/core";
import { AlertifyService } from "../../services/alertify.service";
import { Department } from "../../models/department";
import { DepartmentService } from "../../services/department.service";

@Component({
  selector: "app-department-list",
  templateUrl: "./department-list.component.html",
  styleUrls: ["./department-list.component.css"]
})
export class DepartmentListComponent implements OnInit {
  department: Department[];

  constructor(
    private depertmentService: DepartmentService,
    private alertify: AlertifyService
  ) {}

  ngOnInit() {
    this.loadDepartments();
  }

  loadDepartments() {
    this.depertmentService.getDepartments().subscribe(
      (departments: Department[]) => {
        this.department = departments;
      },
      error => {
        this.alertify.error(error);
      }
    );
  }
}

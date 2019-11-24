import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { Observable } from "rxjs";
import { Department } from "../models/department";

// const httpOptions = {
//   headers: new HttpHeaders({
//     Authorization: "Bearer " + localStorage.getItem("token")
//   })
// };

@Injectable({
  providedIn: "root"
})
export class DepartmentService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getDepartments(): Observable<Department[]> {
    return this.http.get<Department[]>(this.baseUrl + "department");
  }

  getDepartment(id): Observable<Department> {
    return this.http.get<Department>(this.baseUrl + "department/" + id);
  }

  postDepartment(department: Department) {
    return this.http.post(this.baseUrl + "department", department);
  }
}

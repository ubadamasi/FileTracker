import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class TrackerService {
  baseUrl = "http://localhost:5000/api/";
  constructor(private http: HttpClient) {}

  getValues() {
    return this.http.get(this.baseUrl + "values");
  }

  getDepartments() {
    return this.http.get(this.baseUrl + "department");
  }
}

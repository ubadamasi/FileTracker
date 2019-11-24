import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { AdminComponent } from "./admin/admin.component";
import { MailsComponent } from "./mails/mails.component";
import { DepartmentsComponent } from './Departments/Departments.component';
import { AuthGuard } from "./guards/auth.guard";

export const appRoutes: Routes = [
  { path: "", component: HomeComponent },
  { path: "mails", component: MailsComponent, canActivate: [AuthGuard] },
  { path: "departments", component: DepartmentsComponent, canActivate: [AuthGuard] },
  { path: "admin", component: AdminComponent, canActivate: [AuthGuard] },
  { path: "**", redirectTo: "", pathMatch: "full" }
];

import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { BsDropdownModule, ModalModule } from "ngx-bootstrap";
import { RouterModule } from "@angular/router";
import { JwtModule } from "@auth0/angular-jwt";


import { AppComponent } from "./app.component";
import { NavComponent } from "./nav/nav.component";
import { AuthService } from "./services/auth.service";
import { HomeComponent } from "./home/home.component";
import { RegisterComponent } from "./register/register.component";
import { DepartmentsComponent } from "./Departments/Departments.component";
import { DepartmentFormComponent } from "./Departments/department-form/department-form.component";
import { DepartmentListComponent } from "./Departments/department-list/department-list.component";
import { ErrorInterceptorProvider } from "./services/error.interceptor";
import { AlertifyService } from "./services/alertify.service";
import { DepartmentService } from "./services/department.service";
import { AdminComponent } from "./admin/admin.component";
import { MailsComponent } from "./mails/mails.component";
import { appRoutes } from "./routes";
import { AuthGuard } from "./guards/auth.guard";

export function tokenGetter() {
  return localStorage.getItem("token");
}

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    AdminComponent,
    MailsComponent,
    DepartmentsComponent,
    DepartmentFormComponent,
    DepartmentListComponent
  ],
  imports: [
  BrowserModule,
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    RouterModule.forRoot(appRoutes),
    JwtModule.forRoot({
      config: {
        tokenGetter : tokenGetter,
        whitelistedDomains: ['localhost:5000'],
        blacklistedRoutes: ['localhost:5000/api/auth']
      }
    })
  ],
  providers: [
    AuthService,
    DepartmentService,
    ErrorInterceptorProvider,
    AlertifyService,
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}

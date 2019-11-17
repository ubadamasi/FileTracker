import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { BsDropdownModule, ModalModule } from "ngx-bootstrap";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavComponent } from "./nav/nav.component";
import { AuthService } from "./services/auth.service";
import { HomeComponent } from "./home/home.component";
import { RegisterComponent } from "./register/register.component";
import { ErrorInterceptorProvider } from "./services/error.interceptor";
import { AlertifyService } from "./services/alertify.service";
import { AdminComponent } from "./admin/admin.component";
import { MailsComponent } from "./mails/mails.component";
import { appRoutes } from "./routes";
import { AuthGuard } from "./guards/auth.guard";

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    AdminComponent,
    MailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    AuthService,
    ErrorInterceptorProvider,
    AlertifyService,
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}

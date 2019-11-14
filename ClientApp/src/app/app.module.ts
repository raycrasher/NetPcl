import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { PclItemComponent } from './pcl-item/pcl-item.component';
import { PclSheetComponent } from './pcl-sheet/pcl-sheet.component';
import { CreateTestSuiteComponent } from './create-test-suite/create-test-suite.component';
import { EditTestSuiteComponent } from './edit-test-suite/edit-test-suite.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    PclItemComponent,
    PclSheetComponent,
    CreateTestSuiteComponent,
    EditTestSuiteComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'newpcl', component: CreateTestSuiteComponent },
      { path: 'editpcl/:id', component: EditTestSuiteComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

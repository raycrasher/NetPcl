import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { RepositoryService } from "src/app/repository.service"
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-test-suite',
  templateUrl: './create-test-suite.component.html',
  styleUrls: ['./create-test-suite.component.css']
})
export class CreateTestSuiteComponent {

  name:string;
  description:string;
  error:string;

  constructor(private http: HttpClient, private repo:RepositoryService, private router:Router) {
    
  }

  async save()
  {
    this.error="";
    if(this.name == null || this.name.length == 0) {
      this.error="Please put in a name.";
      return;
    }
    if(this.description==null){
      this.description="";
    }
    var suite = await this.repo.createTestSuite(this.name, this.description);
    if(suite == null){
      this.error="An error occurred while creating the new PCL.";
    }
    else {
      this.router.navigate(['/editpcl/'+suite.id]);
    }
  }
}

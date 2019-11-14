import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TestSuite, TestSheet, Result } from 'src/app/models'
import { promise } from 'protractor';

@Injectable({providedIn: 'root'})
export class RepositoryService {
    baseUrl: string;

  constructor(private http: HttpClient) 
  { 
      this.baseUrl = "https://localhost:5001";
  }

  async createTestSuite(name: string, desc: string) : Promise<TestSuite> {
    try {
      var postData = {
        name:name,
        description:desc,
        sheets:[]
      };

        var result = await this.http.post<Result<number>>(this.baseUrl + "/api/pcl", postData).toPromise();
      if(result.ok) {
        var ts=new TestSuite();
        ts.name=name;
        ts.description=desc;
        ts.id = result.data;
        return ts;
      }

      return null;
    } catch(x){
      return null;
    }
    }

    async getTestSuite(id: number): Promise<TestSuite> {
        try {
            var result = await this.http.get<Result<TestSuite>>(this.baseUrl + "/api/pcl/"+id).toPromise();
            if(result.ok) {
              return result.data;
            }
            else{
              return null;
            }
        }
        catch(x){
            return null;
        }
    }

}

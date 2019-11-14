import { Component, OnInit } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { TestSuite, TestSheet } from '../models'
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { RepositoryService } from '../repository.service';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-edit-test-suite',
  templateUrl: './edit-test-suite.component.html',
  styleUrls: ['./edit-test-suite.component.css']
})
export class EditTestSuiteComponent implements OnInit {

    suite: TestSuite;
    newSheetNum:number=1;

    constructor(private route: ActivatedRoute,
        private router: Router,
        private repo: RepositoryService) { }

    ngOnInit() {
        console.log("init edit test suite");
        this.route.paramMap.pipe(
            switchMap((params: ParamMap) => this.repo.getTestSuite(Number(params.get("id"))))
        ).subscribe(o => {

            this.suite = o;
            console.log(o);
        });
    }

    addSheet(){
        if(this.suite == null){
            return;
        }
        var sheet = new TestSheet();
        sheet.id = 0; // TODO
        sheet.name="New Sheet " + this.newSheetNum;
        sheet.factors = [];
        this.suite.sheets.push(sheet);
        this.newSheetNum++;
    }

    removeSheet(sheet:TestSheet){
        if(this.suite == null || sheet==null)
            return;
        this.suite.sheets = this.suite.sheets.filter(s=>s!==sheet);
    }
}

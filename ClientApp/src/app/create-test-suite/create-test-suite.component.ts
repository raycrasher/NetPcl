import { Component, OnInit } from '@angular/core';
import { TestSuite, TestSheet } from '../models';

@Component({
  selector: 'app-create-test-suite',
  templateUrl: './create-test-suite.component.html',
  styleUrls: ['./create-test-suite.component.css']
})
export class CreateTestSuiteComponent implements OnInit {

  testSuite: TestSuite;

  constructor() {
  }

  ngOnInit() {
  }

  addSheet() {
    this.testSuite.sheets.push(new TestSheet());
  }

}

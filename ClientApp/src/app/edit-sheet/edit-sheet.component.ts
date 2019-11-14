import { Component, OnInit, Input } from '@angular/core';
import { TestSheet } from '../models';

@Component({
  selector: 'app-edit-sheet',
  templateUrl: './edit-sheet.component.html',
  styleUrls: ['./edit-sheet.component.css']
})
export class EditSheetComponent implements OnInit {

  @Input()
  sheet:TestSheet;

  constructor() { }

  ngOnInit() {
  }

}

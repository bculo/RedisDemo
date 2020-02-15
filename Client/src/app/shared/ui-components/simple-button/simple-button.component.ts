import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-simple-button',
  templateUrl: './simple-button.component.html',
  styleUrls: ['./simple-button.component.css']
})
export class SimpleButtonComponent implements OnInit {

  @Input() content: string;
  @Output() click: EventEmitter<any> = new EventEmitter();

  constructor() {}

  ngOnInit() {}

}

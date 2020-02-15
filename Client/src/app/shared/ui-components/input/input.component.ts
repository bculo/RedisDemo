import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css']
})
export class InputComponent implements OnInit {

  @Input() placeholder: string;
  @Input() id: string;
  @Input() type: string;
  @Input() label: string;

  constructor() { }

  ngOnInit() {
  }

}

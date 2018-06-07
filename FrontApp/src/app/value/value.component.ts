import { Component, OnInit } from '@angular/core';
import { ValueService } from '../value.service';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  value: string;
  constructor(private valueService: ValueService) { }

  ngOnInit() {
    this.getValue();
  }

  getValue(): void {
    this.valueService.getValue().subscribe(value => this.value = value);
  }

}

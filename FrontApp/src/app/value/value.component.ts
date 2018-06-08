import { Component, OnInit } from '@angular/core';
import { ValueService } from '../value.service';
import { Item } from '../domain/item';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  items: Item[];
  constructor(private valueService: ValueService) { }

  ngOnInit() {
    this.getValue();
  }

  getValue(): void {
    this.valueService.getAll().subscribe(value => this.items = value);
  }

}

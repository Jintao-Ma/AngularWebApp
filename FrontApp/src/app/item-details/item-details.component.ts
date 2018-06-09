import { Component, OnInit, Input } from '@angular/core';
import { Item } from '../domain/item';
import {ValueService} from '../value.service';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styleUrls: ['./item-details.component.css']
})
export class ItemDetailsComponent implements OnInit {

  constructor(private valueService: ValueService) { }

  @Input() item: Item = { id: 1, name: 'Lego'};

  ngOnInit() {
    //this.getItem();
  }

  getItem(): void {
    this.valueService.getItem().subscribe(value => this.item = value);
  }

}

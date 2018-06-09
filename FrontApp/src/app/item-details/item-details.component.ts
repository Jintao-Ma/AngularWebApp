import { Component, OnInit, Input } from '@angular/core';
import { Item } from '../domain/item';
import {ValueService} from '../value.service';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styleUrls: ['./item-details.component.css']
})
export class ItemDetailsComponent implements OnInit {

  constructor(private valueService: ValueService,
        private location: Location,
        private route: ActivatedRoute) { }

  @Input() item: Item = { id: 1, name: 'Lego'};
  id: number = +this.route.snapshot.paramMap.get('id');

  ngOnInit() {
    this.getItem();
  }

  getItem(): void {
    
    this.valueService.getItem(this.id).subscribe(value => this.item = value);
  }

  update(): void {
    this.valueService.updateItem(this.id, this.item).subscribe(value => this.item = value);
  }

  delete(): void{
    this.valueService.deleteItem(this.id);
    //this.goBack();
  }

  goBack(): void {
    this.location.back();
  }

}

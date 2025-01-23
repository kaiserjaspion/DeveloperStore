import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Rating {
  rate: number;
  count: number
}
interface Products {
  id: number;
  title: string;
  price: number;
  description: string;
  category: string;
  image: string;
  rating: Rating;
}


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  public Products: Products[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getForecasts();
  }

  getForecasts() {
    this.http.get<Products[]>('/Products').subscribe(
      (result) => {
        this.Products = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'developer.store.client';
}

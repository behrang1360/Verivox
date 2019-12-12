import { Injectable, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Product } from "../models/product";

@Injectable({
  providedIn: "root"
})
export class TarrifServiceService implements OnInit {
  constructor(private http: HttpClient) {}
  ngOnInit(): void {}

  getProductList(value: number): Observable<Product[]> {
    return this.http.get<Product[]>(
      `http://localhost:5000/ProductTarrifComparison/${value}`
    );
  }
  
}

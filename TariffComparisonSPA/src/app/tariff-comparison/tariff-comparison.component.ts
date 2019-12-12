import { Component, OnInit, Input } from "@angular/core";
import { TarrifServiceService } from "../services/tarrifService.service";
import { map } from "rxjs/operators";
import { Product } from "../models/product";
import { NgForm } from "@angular/forms";
import { error } from "util";
import { AlertifyService } from "../services/alertify.service";

@Component({
  selector: "app-tariff-comparison",
  templateUrl: "./tariff-comparison.component.html",
  styleUrls: ["./tariff-comparison.component.css"]
})
export class TariffComparisonComponent implements OnInit {
  listProduct: Product[];
  displayedColumns: string[] = ["tarrifName", "annualCost"];
  dataSource: Product[];
  comparison: number;
  constructor(
    private tarrifSrv: TarrifServiceService,
    private alertify: AlertifyService
  ) {}

  ngOnInit() {}

  calculate(form: NgForm) {
    this.tarrifSrv.getProductList(form.value.consumption).subscribe(
      args => {
        this.dataSource = args;
      },
      error => {
        this.alertify.error(error);
        console.log(error);
      }
    );
  }
}

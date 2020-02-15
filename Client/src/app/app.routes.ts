import { Routes } from "@angular/router";
import { AddComponent } from "./components/add/add.component";
import { GetComponent } from "./components/get/get.component";
import { RemoveComponent } from "./components/remove/remove.component";

export const routes: Routes = [
  { path: "", redirectTo: "add", pathMatch: "full" },
  { path: "add", component: AddComponent },
  { path: "get", component: GetComponent },
  { path: "remove", component: RemoveComponent }
];

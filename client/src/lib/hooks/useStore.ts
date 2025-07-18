import { useContext } from "react";
import { StoreContext } from "../stores/store";

export default function useStore() {
  return useContext(StoreContext)
}
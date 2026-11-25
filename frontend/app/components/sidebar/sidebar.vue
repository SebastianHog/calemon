<template>
  <section v-if="isDesktop" class="sidebar-wrapper-desktop">
    <ul class="">
      <li v-for="option in sidebarOptions">
        <a :href="option.link">
          {{ option.label }}
        </a>
      </li>
    </ul>
  </section>
</template>

<script setup lang="ts">
import { useViewport } from "~/composables/useViewport";

const viewport = useViewport();
const isDesktop = ref(false);

onMounted(() => {
  isDesktop.value = viewport.value === "desktop";
});

interface props {
  sidebarOptions: {
    label: string;
    link: string;
  }[];
}

defineProps<props>();
</script>

<style lang="scss" src="./styles.scss"></style>

<template>
  <section class="example-component" :class="{ 'example-component--highlighted': highlighted }">
    <h2 class="example-component__title">{{ title }}</h2>
    <div class="example-component__body">
      <slot />
    </div>
  </section>
</template>

<script setup lang="ts">
// Template for new components: copy the folder, rename folder, files and the .example-component class.
// Used as <ExampleComponent>
defineProps<{
  title: string;
  highlighted?: boolean;
}>();
</script>

<style lang="scss" src="./styles.scss"></style>
